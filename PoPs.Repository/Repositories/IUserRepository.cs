﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PoPs.Domain;

namespace PoPs.Repository.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);

        void Create(User user);

        IEnumerable<User> GetAll();

        void Update(User user);
    }
}
