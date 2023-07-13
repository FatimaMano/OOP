class Muser:
    username = ""
    userpassword = ""
    userRole = ""
    def __init__(self,username,userpassword,role):
        self.username = username
        self.userpassword = userpassword
        self.userRole = role
    def isAdmin(self):
        if(self.UserRole == "Admin"):
            return True
        else: 
            return False
