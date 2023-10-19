using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdDmpCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdDmpCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝统一编码，2088开头字符串。人群包创建人id
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 行为分类标签
        /// </summary>
        [XmlArray("behavior_types")]
        [XmlArrayItem("string")]
        public List<string> BehaviorTypes { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 非必传，创建人群后接口会返回创建成功的人群包编码。更新操作时该人群包编码必传
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 创建或更新人群时需传入的人群包名称，人群包名称最长不超过30
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 设备数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 设备号数据，元素个数不能超过2000
        /// </summary>
        [XmlArray("device_ids")]
        [XmlArrayItem("string")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 人群包有效日期的结束时间，结束时间不能小于开始时间。
        /// </summary>
        [XmlElement("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 是否上传完成标识。设备号数据分批次上传时最后一个批次为true，其他批次为false。
        /// </summary>
        [XmlElement("if_end")]
        public bool IfEnd { get; set; }

        /// <summary>
        /// 人群包有效期的开始时间，开始时间不能小于当前时间，且开始时间不能大于结束时间。
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 操作类型，每次操作必传
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 商家在灯火的唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 调用接口创建或更新人群包时需生成的唯一的操作id，不受设备号数据分批次影响。如2000条数据分两批次上传，本次操作两批次的uuid保持一致
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
