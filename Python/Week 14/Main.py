from MuserDL import MuserDL
from MuserUI import MuserUI
import os
from time import sleep
# Defining Main Function
def main():
    path = "Data.txt"
    MuserDL.readDataFromFile(path)
    option = 0
    while (option != 3):
        os.system("cls")
        option = MuserUI.menu()
        if (option == 1):
            user = MuserUI.takeInputwithOutRole()
            user = MuserUI.SignIn(user)
            if (user != None):
                if (user.isAdmin()):
                    print("This is Admin")
                    #Admin Menu
                else:
                    print("This is User")
                    #User Menu
                sleep(3)
        elif (option == 2):
            user = MuserUI.TakeInputFromConsole()
            MuserDL.addUserIntoList(user)
            MuserDL.storeUserIntoFile(user, path)

if __name__ == "__main__":
    main()