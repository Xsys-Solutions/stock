using System.Collections.Generic;

namespace Services.Interface
{
    public interface IGlobalValidation<TRequest>
    {
        ICollection<string> Validation(TRequest request);
    }
}
