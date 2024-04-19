using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodContractCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodContractCheckavailableModel : AopObject
    {
        /// <summary>
        /// 支付宝的服务合约编号 (服务出单接口中携带的那个)
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }
    }
}
