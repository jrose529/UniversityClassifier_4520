import pandas as pd 
import numpy as np 


ranking = pd.read_csv('ranking.csv').fillna(0)
#test = ranking.loc[1,'shanghai'].split('-')
ranking['average'] = 0 

print(len(ranking['shanghai']))
for i in range(0, len(ranking['shanghai'])):
	x = ranking.loc[i,'shanghai']
	#print(type(x))
	if(type(x) is str):
		y = x.split('-')
		if(len(y) == 2): 
			ranking.loc[i,'shanghai'] = (int(y[0]) + int(y[1]))/2
		
	x = ranking.loc[i,'times']
	#print(type(x))
	if(type(x) is str):
		y = x.split('-')
		if(len(y) == 2): 
			ranking.loc[i,'times'] = (int(y[0]) + int(y[1]))/2
	allVals = [ranking['times'][i], ranking['cwur'][i], ranking['shanghai'][i]].count(0) 
	if allVals == 0: 
		ranking['average'][i] = sum([int(ranking['cwur'][i]), int(ranking['shanghai'][i]), int(ranking['times'][i])])/3

	if allVals == 1: 
		ranking['average'][i] = sum([int(ranking['cwur'][i]), int(ranking['shanghai'][i]), int(ranking['times'][i])])/2

	if allVals == 2: 
		ranking['average'][i] = sum([int(ranking['cwur'][i]), int(ranking['shanghai'][i]), int(ranking['times'][i])])/1

ranking = ranking.sort_values(by=['average'])
ranking['overallRank'] = 1
rank = 1 
change = [259, 259, 777, 1036]
for i in range(0, len(ranking['shanghai'])):
	ranking['overallRank'][i] = rank 
	if i in change:
		rank = rank+1
 


	
ranking.to_csv('test2.csv')
		
