import pandas as pd 
import numpy as np

cwur = pd.read_csv('cwurData.csv')
cwur = cwur[cwur["year"] == 2015] 
rank1 =cwur[["institution", "world_rank"]] 
rank1 = rank1.rename(index = int, columns= { "institution": "school", "world_rank": "cwur"})
rank1.school.replace('the', '', regex=True,inplace=True)
rank1.school.replace('The', '', regex=True,inplace=True)
rank1.school.replace('-', '', regex=True,inplace=True)
rank1.school.replace(',', '', regex=True,inplace=True)
rank1.school.replace(' in ', '', regex=True,inplace=True)
rank1.school.replace("'", regex=True,inplace=True)
rank1.school.replace(' ', '', regex=True,inplace=True)

rank1.school = rank1.school.str.strip()


print(rank1)

shanghai = pd.read_csv("shanghaiData.csv") 
shanghai = shanghai[shanghai["year"] == 2015]
rank2 = shanghai[["university_name", "world_rank"]]
rank2 = rank2.rename(index = int, columns = {"university_name": "school", "world_rank": "shanghai"})
rank2.school.replace('the', '', regex=True,inplace=True)
rank2.school.replace('The', '', regex=True,inplace=True)
rank2.school.replace('-', '', regex=True,inplace=True)
rank2.school.replace(',', '', regex=True,inplace=True) 
rank2.school.replace(' in ', '', regex=True,inplace=True)
rank2.school.replace("'", regex=True,inplace=True)
rank2.school.replace(' ', '', regex=True,inplace=True)
rank2.school = rank2.school.str.strip()

print(rank2)


times = pd.read_csv("timesData.csv")
times = times[times["year"] == 2016]
rank3 = times[["university_name", "world_rank"]]
rank3 = rank3.rename(index = int, columns = {"university_name" : "school", "world_rank" : "times"})
rank3.school.replace('the', '', regex=True,inplace=True)
rank3.school.replace('The', '', regex=True,inplace=True)
rank3.school.replace('-', '', regex=True,inplace=True)
rank3.school.replace(',', '', regex=True,inplace=True) 
rank3.school.replace(' in ', '', regex=True,inplace=True)
rank3.school.replace("'", regex=True,inplace=True)
rank3.school.replace(' ', '', regex=True,inplace=True)
rank3.school = rank3.school.str.strip()
print(rank3)

test = rank1.merge(rank2, on= "school", how = "outer")
#print(test)
test2 = test.merge(rank3, on= "school", how = "outer")
#test2["score"] = test2["cwur"] + test2["shanghai"] + test2["times"] / 3;   
test2.to_csv("ranking.csv")
print(test2)
 
