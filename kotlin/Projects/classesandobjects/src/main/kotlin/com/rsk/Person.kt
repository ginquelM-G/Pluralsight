package com.rsk

/**
 * Created by User01 on 25/10/2017..
 */


interface Signatory{
    fun sign()
}


//Open - para a classe deixar de ser final
open class Person(val name: String, var age:Int, var isMarried: Boolean=false): Signatory {

    var partnerName: String = ""

    override fun sign() = println("$name aged $age can sign documents. (and their marital status is $isMarried)")


    //Tipo static em java
    companion object {

        @JvmStatic
        fun main(args: Array<String>){
            val p = Person("Pedro", 23, true)
            p.sign()

            p.age = 54
            p.sign()

            p.partnerName = "Alice"
            println("Partner name is ${p.partnerName}")

            p.partnerName = "Maria"
            println("Partner name is ${p.partnerName}")

            val kevin = User("kevin", 17)
            println(kevin)
        }
    }
}

class Student (name: String, age: Int) : Person(name, age)

// DATA Classes - class to only hold data
data class User(val name:String, val id: Int)



fun main(args: Array<String>){
    val p = Person("Pedro", 23, true)
    p.sign()

    p.age = 54
    p.sign()

    p.partnerName = "Alice"
    println("Partner name is ${p.partnerName}")

    p.partnerName = "Maria"
    println("Partner name is ${p.partnerName}")

    val kevin = User("kevin", 17)
    val otherUser = kevin.copy(id=2)
    println(kevin)

    val (name, id) = kevin

    println("user is $name and their id is $id")
    println(otherUser)
}