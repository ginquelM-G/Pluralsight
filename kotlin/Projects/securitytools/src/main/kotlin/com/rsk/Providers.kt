package com.rsk

import java.security.Provider
import java.security.Security

/**
 * Created by Moreira on 21-10-2017.
 */
class Providers {

    fun getProviders() : List<Provider>{
        val providers = Security.getProviders()
        val listOfProviders:List<Provider> = providers.asList()
        return listOfProviders
    }

    // Métodos que seriam *static* em java
    companion object {
        fun getProviders() : List<Provider>{
            val providers = Security.getProviders()
            val listOfProviders:List<Provider> = providers.asList()
            return listOfProviders
        }
    }
}