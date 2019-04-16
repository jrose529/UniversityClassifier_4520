import pymysql
import pandas as pd
from sqlalchemy import create_engine

conn_str = 'mssql+pyodbc://masterusername:masterpassword@uniclassifier.cdbytbcvrrjd.us-east-2.rds.amazonaws.com/tempdb?driver=ODBC+Driver+17+for+SQL+Server'
print(type(conn_str))
print(conn_str)
#engine = create_engine(conn_str)
#conn = engine.connect()

my_df = pd.read_csv('test2.csv')
#df.to_sql(name='university',con=conn,if_exists='append')
#conn.close()


idx = my_df.index.values
my_df.reset_index(drop=True, inplace=True)
print('idx')
# Set up the database connection
sql_engine = create_engine(conn_str)
conn = sql_engine.connect()
sql_db = pd.io.sql.SQLDatabase(sql_engine)
print("connect")
# Create the db table if necessary
if not sql_db.has_table("university"):
    args = ["university", sql_db]
    kwargs = {
        "frame" : my_df,
        "index" : True, 
        "index_label" : "id",
        "keys" : "id"
    }
    sql_table = pd.io.sql.SQLTable(*args, **kwargs)
    sql_table.create()
    print("table")

# Insert the DataFrame rows into the table via to_sql() method (omit the index)
my_df.to_sql(name="university", con=conn, if_exists='replace', index=True)
print("to sql")
