package com.rsk

/**
 * Created by User01 on 25/10/2017..
 */


interface Signatory{
    fun sign()
}

//Open - para a classe deixar de ser final
open class Person(val name: String, var age:Int, var isMarried: Boolean=false): Signatory {

    /*var isMarried = false

    //Secondary constructor
    constructor(name: String, age: Int, isMarried: Boolean): this(name, age){
        this.isMarried = isMarried
    }*/
    /*init{
        if(name == "Ginquel" && age < 54) throw Exception("Invalid age")
    }*/



    override fun sign() = println("$name aged $age can sign documents. (and their marital status is $isMarried)")
}

class Student (name: String, age: Int) : Person(name, age)



fun main(args: Array<String>){
    val p = Person("Ginquel", 23, true)
    p.sign()

    p.age = 54
    p.sign()

    p
}