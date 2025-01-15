namespace GeopagosChallenge.Domain.Interfaces
{
  public interface IValidator<T>
  {
    /// <summary>
    /// Validates the entity.
    /// </summary>
    /// <param name="entity">Entity to validate.</param>
    void Validate(T entity);
  }
}
