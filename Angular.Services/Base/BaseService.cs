using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Data.IRepository.Base;
using Angular.Data.IServices.Base;

namespace Angular.Services.Base
{
    public class BaseService:IService
    {
        IUnitOfWork _unitOfWork = null;
        public BaseService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("DbContext cannot be null.");
            }
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            if (this._unitOfWork != null)
            {
                this._unitOfWork.Dispose();
                this._unitOfWork = null;
            }
        }
    }


}
