import pymysql
import pandas as pd
from sqlalchemy import create_engine

conn_str = 'mssql+pyodbc://masterusername:masterpassword@uniclassifier.cdbytbcvrrjd.us-east-2.rds.amazonaws.com/tempdb?driver=ODBC+Driver+17+for+SQL+Server'
print(type(conn_str))
print(conn_str)
engine = create_engine(conn_str)
conn = engine.connect()

df = pd.read_csv('Admission_Predict.csv')
df.to_sql(name='academicData',con=conn,if_exists='append')
conn.close()


