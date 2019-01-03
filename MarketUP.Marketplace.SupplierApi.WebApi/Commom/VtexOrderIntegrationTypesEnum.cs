using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Common
{
    public enum VtexOrderIntegrationTypesEnum
    {
        None = 0,

        /// <summary>
        /// Venda de produtos da própria instalação VTEX, ex: Sawary
        /// </summary>
        Fulfillment = 1,

        /// <summary>
        /// Instalação da VTEX é um Marketplace que vende produtos de outras instalação VTEX, ex: Netsuprimentos
        /// </summary>
        Marketplace = 2
    }
}
