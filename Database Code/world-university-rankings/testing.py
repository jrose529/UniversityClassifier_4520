import pandas as pd

d = {'col1': ['testing', 'test'], 'col2': [3, 4]}
df = pd.DataFrame(data=d)
test = df.col1.str.strip('ing')
df.col1 = test
print(df)
