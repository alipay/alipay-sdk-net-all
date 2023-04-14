using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BkAgentRespInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BkAgentRespInfo : AopObject
    {
        /// <summary>
        /// 枚举值，01 银联；02 网联；03 连通等
        /// </summary>
        [XmlElement("bindclrissr_id")]
        public string BindclrissrId { get; set; }

        /// <summary>
        /// 付款机构在清算组织登记或分配的机构代码
        /// </summary>
        [XmlElement("bindpyeracctbk_id")]
        public string BindpyeracctbkId { get; set; }

        /// <summary>
        /// 原快捷交易流水号
        /// </summary>
        [XmlElement("bindtrx_id")]
        public string BindtrxId { get; set; }

        /// <summary>
        /// 用户在银行付款账号的标记化处理编号
        /// </summary>
        [XmlElement("bkpyeruser_code")]
        public string BkpyeruserCode { get; set; }

        /// <summary>
        /// 设备推测位置
        /// </summary>
        [XmlElement("estter_location")]
        public string EstterLocation { get; set; }
    }
}
