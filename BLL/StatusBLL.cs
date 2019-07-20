using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class StatusBLL
    {
        private StatusDAL statusDAL;

        public StatusBLL()
        {
            statusDAL = new StatusDAL();
        }

        public void SalvarStatus(Status status)
        {
            statusDAL.SalvarStatus(status);
        }

        public void AlterarStatus(Status status)
        {
            statusDAL.AlterarStatus(status);
        }

        public List<Status> ConsultarStatus(string nome)
        {
            return statusDAL.ConsultarStatus(nome);
        }

        public void ExcluirStatus(int id)
        {
            statusDAL.ExcluirStatus(id);
        }
    }
}
