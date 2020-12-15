using BUS.Common.Interfaces;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Common
{
    public class BaseService<T> : IBaseService<T> where T : class
    {

    }
}
