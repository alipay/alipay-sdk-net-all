using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyTaskQueryModel : AopObject
    {
        /// <summary>
        /// 门店作业单据标识唯一标识，一个作业单据只需要支付一次保证金
        /// </summary>
        [XmlElement("shop_task_id")]
        public string ShopTaskId { get; set; }
    }
}
