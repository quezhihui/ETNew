namespace ET.Core.Abstraction.Repo
{
    /// <summary>
    /// Defines the interfaces for <see cref="IBaseRepository{TEntity}"/> interfaces.
    /// </summary>
    public interface IRepositoryFactory
    {
        /// <summary>
        /// Gets the specified repository for the <typeparamref name="TEntity"/>.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>An instance of type inherited from <see cref="IBaseRepository{TEntity}"/> interface.</returns>
        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
