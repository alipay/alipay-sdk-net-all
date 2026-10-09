using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfThirdpartylogisticsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfThirdpartylogisticsSyncModel : AopObject
    {
        /// <summary>
        /// WF站点的ipay user id，我们用做siteUserId
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 包含多个offerid对应的3PL数据
        /// </summary>
        [XmlArray("lending_data_list")]
        [XmlArrayItem("lending_data_list")]
        public List<LendingDataList> LendingDataList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
