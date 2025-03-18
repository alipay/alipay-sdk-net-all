using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollaborateTask Data Structure.
    /// </summary>
    [Serializable]
    public class CollaborateTask : AopObject
    {
        /// <summary>
        /// 活动描述，用户参与活动时返回。
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// 活动id，用户参与活动时返回。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型，用户参与活动时返回。
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 任务拉取时该字段无返回内容，确认商户有安装意图时返回该字段
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市级编码，入：330100 表示杭州市。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// pull接口返回脱敏后的联系人姓名，如刘*,confirm接口确认商家有意愿安装，则返回完整的联系人姓名。
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 任务分配的时间。
        /// </summary>
        [XmlElement("dispatched_time")]
        public string DispatchedTime { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称。
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 外部展业人员编号
        /// </summary>
        [XmlElement("installer_no")]
        public string InstallerNo { get; set; }

        /// <summary>
        /// 服务商可以基于此id判断拉取到的任务需要协同什么样的产品，如： N7 设备。
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 协同产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 协同产品标签，如：0元先享等。
        /// </summary>
        [XmlArray("product_tags")]
        [XmlArrayItem("string")]
        public List<string> ProductTags { get; set; }

        /// <summary>
        /// 省级地址编码，如：330000 表示浙江。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称。
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 任务拉取时该字段无返回内容，确认领取时会返回该字段。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 任务拉取时该字段无返回内容，确认领取且当前商户是你方商户时返回该字段。
        /// </summary>
        [XmlArray("smid_list")]
        [XmlArrayItem("string")]
        public List<string> SmidList { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }

        /// <summary>
        /// 任务标签，如：强意愿用户
        /// </summary>
        [XmlArray("task_tags")]
        [XmlArrayItem("string")]
        public List<string> TaskTags { get; set; }

        /// <summary>
        /// 任务拉取时无该内容返回，确认领取时返回脱敏内容，如131****2222，确认商户有意图或呼叫商户N次未接通的情况会返回该字段未脱敏数据，N以实际业务沟通为准
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
