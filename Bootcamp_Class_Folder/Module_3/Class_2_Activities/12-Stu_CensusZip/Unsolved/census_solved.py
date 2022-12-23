import os

import csv

census_csv = os.path.join('..','Resources', 'census_starter.csv')

places =[]
population = []
income = []
povertyCount = []
povertyRate = []
county = []
state = []


with open (census_csv) as csvfile:
    csvreader = csv.reader(csvfile, delimiter=",")
    #why do we have to create thes variables/aliases?

    for row in csvreader:
        places.append(row[0])
        population.append(row[1])
        income.append(row[4])
        povertyCount.append(row[8])
        
        
        percent = round(int(row[8]) / int(row[1]) * 100, 2)
        povertyRate.append(str(percent) + '%')
        print (povertyRate)

        splitString = row[0].split(',')
        county.append(splitString[0])
        state.append(splitString[1])

cleanedCsv = zip(places,population,income,povertyCount,povertyRate,county,state)

outPutFile = os.path.join('census_final.csv')
#what is the syntax for this ^ why does path not have to be specified?

with open(outPutFile,'w') as datafile:
    #ask chris about this 'w'
    writer = csv.writer(datafile)
    
    #this is header row
    writer.writerow(['Place','Population','Per Capita Income', 'Poverty Count', 'Poverty Rate', 'County', 'State'])

    writer.writerows(cleanedCsv)








