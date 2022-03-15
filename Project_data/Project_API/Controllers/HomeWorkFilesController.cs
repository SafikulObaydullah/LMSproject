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
    public class HomeWorkFilesController : ApiController
    {
        RepositoryAccess repositoryAccess = new RepositoryAccess();
        public HomeWorkFilesController()
        {

        }
        public string Post(HomeWorkFile homeWorkFile)
        {
            repositoryAccess.HomeWorkFileRepo.Add(homeWorkFile);
            return repositoryAccess.UnitOfWork.Commit();
        }
        public string Delete(int id)
        {
            repositoryAccess.HomeWorkFileRepo.Delete(id);
            return repositoryAccess.UnitOfWork.Commit();
        }
        public IEnumerable<HomeWorkFile> Get()
        {
            return repositoryAccess.HomeWorkFileRepo.GetAll();
        }
        public HomeWorkFile Get(int id)
        {
            return repositoryAccess.HomeWorkFileRepo.GetById(id);
        }
        public string Put(HomeWorkFile homeWorkFile)
        {
            repositoryAccess.HomeWorkFileRepo.update(homeWorkFile);
            return repositoryAccess.UnitOfWork.Commit();
        }
    }
}
