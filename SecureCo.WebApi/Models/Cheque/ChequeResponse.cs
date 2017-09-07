using System;
using System.Collections;
using System.Collections.Generic;
using SecureCo.Services.DTO;

namespace SecureCo.WebApi.Models.Cheque
{

    public class ChequeResponse : BaseApiResponse
    {
        public ChequeDto Cheque { get; set; }

    }

    public class ChequeListResponse : BaseApiResponse
    {
        public IEnumerable<ChequeDto> Cheques { get; set; }

    }
}