using AutoMapper;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

namespace StoreApp.StoreApp.Web.Models;

public class MapperProfile:Profile
{
    public MapperProfile()
    {
        CreateMap<Product, ProductViewModel>();
    }
}