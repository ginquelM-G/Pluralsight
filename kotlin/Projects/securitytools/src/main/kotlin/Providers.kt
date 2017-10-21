import java.security.Provider
import java.security.Security

/**
 * Created by Moreira on 21-10-2017.
 */

fun getProviders() : List<Provider>{
    val providers = Security.getProviders()
    val listOfProviders:List<Provider> = providers.asList()
    return listOfProviders
}