using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardTemplateConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardTemplateConfDTO : AopObject
    {
        /// <summary>
        /// 连续售卖配置
        /// </summary>
        [XmlElement("cycle_selling_conf")]
        public PaidOuterCardCycleSellConfDTO CycleSellingConf { get; set; }

        /// <summary>
        /// 生命周期管理地址
        /// </summary>
        [XmlElement("manage_url_conf")]
        public PaidOuterCardManageUrlConfDTO ManageUrlConf { get; set; }

        /// <summary>
        /// 售卖基础配置
        /// </summary>
        [XmlElement("open_selling_conf")]
        public PaidOuterCardSellingConfDTO OpenSellingConf { get; set; }
    }
}
