from Muser import Muser
class MuserUI:
    @staticmethod
    def menu():
        print("1.SignIn")
        print("2.SignUp")
        print("3.Enter Option")
        option = int(input())
        return option
    @staticmethod
    def printList(userList):
        for user in userList:
            print(user.username,user.userpassword,user.userRole)
    @staticmethod
    def TakeInputFromConsole():
        username = input("Enter Username")
        userpassword = input("Enter Password")
        userRole = input("Enter Role")
        user = Muser(username,userpassword,userRole)
        return user
    @staticmethod
    def TakeInputwithOutRole():
        username = input("Enter Username")
        userpassword = input("Enter Password")
        user = Muser(username,userpassword)
        return user

        
