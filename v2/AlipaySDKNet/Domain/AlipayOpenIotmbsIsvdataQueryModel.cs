using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvdataQueryModel : AopObject
    {
        /// <summary>
        /// 参数名：condition_id+使用场景：根据condition_type，输入相应的查询条件+枚举值： 无
        /// </summary>
        [XmlElement("condition_id")]
        public string ConditionId { get; set; }

        /// <summary>
        /// 参数名：condition_type+使用场景：选择条件查询维度+枚举值：1、isvpid 2、酒店id 3、设备sn
        /// </summary>
        [XmlElement("condition_type")]
        public string ConditionType { get; set; }

        /// <summary>
        /// 参数名:page_num+使用场景:分页查询的页码+枚举值:无
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 参数名:page_size+使用场景：分页查询一页数据的最大条数+枚举值：无
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 参数名：query_type+使用场景：选择需要查询的数据类型+枚举值：1：isv绑定的酒店id 2：设备sn 3：设备sn绑定的人脸
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
