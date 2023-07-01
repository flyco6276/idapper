 public TEntity GetByKeys(params object[] key)
{
           if (_dbContext != null && _dbSet !=  null)
           {
               return _dbSet.Find(key);
           }
           return null;
}

GetByKeys(1, 2, 3); 
GetByKeys(1, 'a', "test"); 
int[] myarray = new int[3] {10,11,12};     
GetByKeys(myarray);  
// An array of objects can also be passed, as long as       
// the array type matches the method being called.    
