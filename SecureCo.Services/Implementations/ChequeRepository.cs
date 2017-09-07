
using System.Collections.Generic;
using System.Linq;
using SecureCo.Data;
using SecureCo.Data.Models;
using SecureCo.Services.DTO;
using SecureCo.Services.Interfaces;

namespace SecureCo.Services.Implementations
{
    public class ChequeRepository : IChequeRepository
    {
        private readonly IDataContext _dataContext;

        public ChequeRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ChequeDto Add(ChequeDto entity)
        {

            var chequeEntity = new Cheque
            {
                ChequeId = entity.ChequeId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Amount = entity.Amount,
                DateCreated = entity.DateCreated,
                DateChanged = entity.DateChanged
            };

            _dataContext.Cheques.Add(chequeEntity);
            _dataContext.SaveChanges();


            return new ChequeDto
            {
                ChequeId = chequeEntity.ChequeId,                
                FirstName = chequeEntity.FirstName,
                LastName = chequeEntity.LastName,
                Amount = chequeEntity.Amount,
                DateCreated = chequeEntity.DateCreated,
                DateChanged = chequeEntity.DateChanged

            };

        }

        public void Remove(int id)
        {
            var contactEntity = _dataContext.Cheques.SingleOrDefault(g => g.ChequeId == id);
            if (contactEntity == null)
                return;

            _dataContext.Cheques.Remove(contactEntity);
            _dataContext.SaveChanges();

        }

        public ChequeDto Update(ChequeDto entity)
        {
            var contactEntity = _dataContext.Cheques.SingleOrDefault(g => g.ChequeId == entity.ChequeId);
            if (contactEntity == null)
                return null;

            contactEntity.LastName = entity.LastName;
            contactEntity.FirstName = entity.FirstName;
            contactEntity.Amount = entity.Amount;

            _dataContext.SaveChanges();

            return new ChequeDto
            {
                ChequeId = contactEntity.ChequeId,
                FirstName = contactEntity.FirstName,
                LastName = contactEntity.LastName,
                Amount = contactEntity.Amount,
                DateChanged = contactEntity.DateChanged,
                DateCreated = contactEntity.DateCreated,
            };
            
        }

        public IEnumerable<ChequeDto> Get()
        {
            return _dataContext.Cheques.Select(g => new ChequeDto
            {
                ChequeId = g.ChequeId,
                LastName = g.LastName,
                FirstName = g.FirstName,
                Amount = g.Amount,
                DateCreated = g.DateCreated,
                DateChanged = g.DateChanged
            }).ToList();
        }

        public ChequeDto Get(int id)
        {
            var chequeEntity = _dataContext.Cheques.SingleOrDefault(g => g.ChequeId == id);
            if (chequeEntity == null)
                return null;
            return new ChequeDto
            {
                ChequeId = chequeEntity.ChequeId,
                FirstName = chequeEntity.FirstName,
                LastName = chequeEntity.LastName,
                Amount = chequeEntity.Amount,
                DateCreated = chequeEntity.DateCreated,
                DateChanged = chequeEntity.DateChanged
            };
        }

    }
}
