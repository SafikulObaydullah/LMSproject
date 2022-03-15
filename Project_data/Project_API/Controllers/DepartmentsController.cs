using Project_data;
using Project_data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_API.Controllers
{
   
    public class DepartmentsController : ApiController
    {
        RepositoryAccess repositoryAccess = new RepositoryAccess();
        public DepartmentsController()
        {

        }
        public string Post(Department department)
        {
            repositoryAccess.DepartmentRepo.Add(department);
            return repositoryAccess.UnitOfWork.Commit();
        }
        public string Delete(int id)
        {
            repositoryAccess.DepartmentRepo.Delete(id);
            return repositoryAccess.UnitOfWork.Commit();
        }
        public IEnumerable<Department> Get()
        {
            return repositoryAccess.DepartmentRepo.GetAll();
        }
        public Department Get(int id)
        {
            return repositoryAccess.DepartmentRepo.GetById(id);
        }
        public string Put(Department department)
        {
            repositoryAccess.DepartmentRepo.update(department);
            return repositoryAccess.UnitOfWork.Commit();
        }
    }
}
