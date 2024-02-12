using Domain;
using MediatR;

namespace Application.Projects
{
    public class List
    {
        public class Query : IRequest<List<Project>> 
        {
            
        }
    }
}
