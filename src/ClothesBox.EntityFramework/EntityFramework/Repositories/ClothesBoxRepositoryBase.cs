using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ClothesBox.EntityFramework.Repositories
{
    public abstract class ClothesBoxRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ClothesBoxDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ClothesBoxRepositoryBase(IDbContextProvider<ClothesBoxDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ClothesBoxRepositoryBase<TEntity> : ClothesBoxRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ClothesBoxRepositoryBase(IDbContextProvider<ClothesBoxDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
