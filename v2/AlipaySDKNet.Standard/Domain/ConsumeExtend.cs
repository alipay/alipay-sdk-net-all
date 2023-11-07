using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumeExtend Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumeExtend : AopObject
    {
        /// <summary>
        /// 是否支持圈店宝
        /// </summary>
        [XmlElement("mall_assign_store")]
        public bool MallAssignStore { get; set; }

        /// <summary>
        /// 余额户钱包是否展示明细，且只在余额户钱包生效
        /// </summary>
        [XmlElement("show_wallet_info_balance")]
        public bool ShowWalletInfoBalance { get; set; }
    }
}
