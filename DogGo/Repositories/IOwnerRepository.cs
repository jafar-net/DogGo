using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGo.Models;
using DogGo.Repositories;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        void UpdateOwner(Owner owner);
        List<Owner> GetAllOwners();
    }
}