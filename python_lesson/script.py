# msg = "helloworld"
# # print(msg)

# name = "someya"
# weight = 70.1

# print("name: %-10s,weight: %-10.1f" %(name, weight))
# print("name: {0:<10s},weight: {1:>10.1f}".format(name, weight))



# score = int(input("score ?"))

# if score > 80:
#   print("great")
# elif score > 60:
#   print("good")
# else:
#   print("so..so..")

# print("great" if score > 80 else "so..so..")



# i = 0
# while i < 10:
#   print(i)
#   if i == 5:
#     break
#   i += 1
# else:
#   print("end")



# for i in range(0, 10):
#   print(i)
# else:
#   print("end")

# def sayHi(name, age = 20):
#   print("hi {0} you are {1} tear(s) old".format(name, age))

# sayHi("somey")



# msg = "hello"

# def sayhi():
#   msg = "hi" #ローカル変数として扱われる。上のmsgの再代入は行われない
#   print(msg)

# def sayglobalhi():
#   global msg
#   msg = "hi" #global変数のmsgに代入
#   print(msg)

# sayhi()
# sayglobalhi()


# class User:
#   pass #空のクラスを作るときはpass

# tom = User()
# tom.name = "tom"
# tom.age = 5 #勝手にメンバを作れる

# hanako = User()
# hanako.name = "hanako"
# hanako.level = 11

# print(tom.age)
# print(hanako.level)

# class User:
#   count = 0 #クラス変数
#   def __init__(self, name):
#     User.count += 1 #クラス変数にアクセスするときはUser.countのようにかく
#     self._name = name #コンストラクタ変数に関してはself.nameのようにすれば良い

#   def sayHi(self):
#     print("{0}".format(self._name))

#   @classmethod #クラスメソッド（インスタンス化不要で使えるメソッド、@classmethodか始める）
#   def showInfo(cls):
#     print("{0}instances".format(cls.count))

# User.showInfo()

# class AdminUser(User):
#   def __init__(self, name, age):
#     super().__init__(name) #継承は引数の名前
#     self.age = age

#   def sayHello(self):
#     print("{0}!{1}".format(self._name, self.age))

#   #overrideするときは断りなしで書ける
#   def sayHi(self):
#     print("[ADMIN]{0}".format(self._name))

# hiro = AdminUser("hiro", 23)
# hiro.sayHello()
# hiro.sayHi()



# class MyException(Exception):
#   pass

# def div(a, b):
#   try:
#     if(b < 0):
#       raise MyException("not minus")

#     print(a / b)
#   except ZeroDivisionError:
#     print("error")
#   except MyException as e:
#     print(e)
#   else:
#     print("no exeption")
#   finally:
#     print("end")

# div(2, -0)



# scores = [40, 50]
# print(scores)
# scores.append(100)
# print(scores)

# for score in scores:
#   print(score)

# for i, score in enumerate(scores):
#   print("{0}:{1}".format(i, score))


# items =(50, "apple", 32.5)
# print(items[0]) #タプルの場合は[0]の用に取り出す、また変更不可

# print(list((1, 3, 5)))
# print(tuple([1, 3, 5]))



#スライスは文字列にも使える
# scores = [10, 20, 30, 40, 50]
# print(scores[1:4]) #添え字1~3まで[20, 30, 40]
# print(scores[:2]) #添え字1まで[10, 20]
# print(scores[3:]) #添え字2から[40, 50]
# print(scores[-3:]) #末尾から添え字3から（末尾が-1）


#セット（重複なし）
# a = set([1, 2, 3, 4, 5, 1, 3, 2]) #a ={1, 2, 3, 4, 5, 1, 3, 2}と同義
# print(a)

# print(5 in a)#含まれるかどうか
# a.add(2)
# a.remove(3)
# print(len(a))

# b = {2, 5, 6, 9, 3}

# print(a | b) #和
# print(a & b) #積
# print(a - b) #差


# sales = {"somey": 200,"takano": 100}
# print(sales["somey"])
# sales["takano"] = 400
# print(sales["takano"])
# sales["dotinstall"] = 300
# del(sales["takano"])
# print(sales)

# for key, value in sales.items():
#   print("{0}:{1}".format(key, value))


#イテレート（遅疑の要素を返すデータの集合）
# scores = [1, 2, 3, 4, 5, 6]
# it = iter(scores)
# print(next(it))
# print(next(it))
# print(next(it))
# print(next(it))

# def get_infinite(): #ジェネレータという
#   i = 0
#   while True:
#     yield i * 2
#     i += 1

# g = get_infinite()
# print(next(g))
# print(next(g))
# print(next(g))
# print(next(g))



#ラムダ式
# print(list(filter(lambda n: n % 2 == 0, map(lambda n: n * 3,[1, 2, 3]))))



# #内包表記
# print([i * 3 for i in range(1, 10) if i % 2 == 0])
# print({i * 3 for i in range(1, 10) if i % 2 == 0})
# print(i * 3 for i in range(1, 10) if i % 2 == 0)