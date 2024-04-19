using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalCvgooodsonlinelistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalCvgooodsonlinelistSyncModel : AopObject
    {
        /// <summary>
        /// 行业的补货业务id,唯一键, 用来做幂等和业务追踪
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 机柜序列号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 存放扩展信息, 用于未来接口信息的扩展
        /// </summary>
        [XmlElement("external_info")]
        public string ExternalInfo { get; set; }

        /// <summary>
        /// 清单中商品的算法id的数组
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }

        /// <summary>
        /// isv的pid号, 不能为空
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 清单提交时间
        /// </summary>
        [XmlElement("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 用来未来业务扩展. 目前为动态补货类型 DYNAMIC_ADDING
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
