

pie_list = ["(1) Pecan", "(2) Apple Crisp", "(3) Bean", "(4) Banoffee",  "(5) Black Bun", "(6) Blueberry", "(7) Buko", "(8) Burek",  "(9) Tamale", "(10) Steak"]
pie_order = []
pie_purchases = [0,0,0,0,0,0,0,0,0,0]
shopping = "y"

print("Welcome to the House of Pies! Here are our pies: ")
print()

print(pie_list)
print()

while shopping == "y":

    selection = int(input("Please enter ther number of the pie you would like to order"))
    pie_name = pie_list[selection - 1]

    print()
    choice_index = selection - 1
    
    #this is making a counter with indexes correlated to pie_list
    pie_purchases[choice_index] += 1

    print("Great! We'll have that " + pie_name + " right out for you")
    pie_order.append(pie_name)

    print()

    shopping = input('Would you like another pie: (y)es or (n)o?')
    

print()

print("----------------")

print(f'Your order has {str(len((pie_order)))} pie(s).')

print(f'Here are the pies in your order: ')

for pie_index in range(len(pie_list)):
    pie_count = str(pie_purchases[pie_index])
    pieNameCart = str(pie_list[pie_index])

    print(pie_count + " " + pieNameCart)






