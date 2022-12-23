import os

import csv

book = input("Please enter the book title you'd like to search for")

found = False

csvpath = os.path.join('..', 'Resources', 'comic_books.csv')
#csv.reader() function

# # Method 1: Plain Reading of CSV files
# with open(csvpath, 'r') as file_handler:
#     lines = file_handler.read()
#     print(lines)
#     print(type(lines))

# Method 2: Improved Reading using CSV module
with open(csvpath) as csvfile:
    csvreader = csv.reader(csvfile, delimiter=',')
    csvHeader = next(csvreader)

    for row in csvreader:
        if row[0] == book:
            print(book + ' was published by ' + row[8] + ' in ' + row[9])
            found = True
    if found is False:
            print(f'Sorry we don\'t have what you\'re looking for')            


    
    
