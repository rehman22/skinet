using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public interface IProductUrlResolver
    {
        string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context);
    }
}