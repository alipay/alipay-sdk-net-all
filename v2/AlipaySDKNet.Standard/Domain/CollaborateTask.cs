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
        /// 活动id，用户参与活动时返回，不为空一定是强leads
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
        /// 餐饮:CATERING 生鲜:FRESH 五金家装:HARDWARE_HOME 超市便利:SUPERMARKET 服装饰品箱包:CLOTHING_ACCESSORIES 美容美发美甲:BEAUTY_SERVICE 数码电器:ELECTRONICS 文体娱乐:ENTERTAINMENT 教育:EDUCATION 彩妆护肤:COSMETICS 生活服务:LIFE_SERVICE 出租车:TAXI 其他:OTHER
        /// </summary>
        [XmlElement("biz_industry")]
        public string BizIndustry { get; set; }

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
        /// 如果为空默认是N7，商户需要铺设设备的类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

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
        /// 线上强leads签约了必有，对接了强弱融合模式的服务商，需要通过接口alipay.offline.provider.nsales.activity.effect 来激活任务
        /// </summary>
        [XmlElement("sales_order_id")]
        public string SalesOrderId { get; set; }

        /// <summary>
        /// 任务拉取时该字段无返回内容，确认领取时会返回该字段。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 任务拉取时该字段无返回内容，确认领取且当前商户是你方存量商户时返回该字段，通过此字段判断是否是你方的存量商户，为空则是非存量leads，非存量leads判断下联系方式是否已下发，未下发的需要走外呼获取
        /// </summary>
        [XmlArray("smid_list")]
        [XmlArrayItem("string")]
        public List<string> SmidList { get; set; }

        /// <summary>
        /// 商户在线上有签约意愿时必有，结合task_tag字段判断是否签约，未签约或者当前字段为空或者activity_id字段为空则是弱leads
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }

        /// <summary>
        /// 任务标签，解释说明: WILLNGNESS -强意愿用户（多次提报） NOT_SIGNING -线上未签约，如果solutionId不为空则说明有签约意愿但是并没有实际签约动作，作业时可以做商户行为参考 HAS_SIGNED-线上已签约，作业时如果需要切换任务，需要先退出卖进方案 STOCK-线下存量摸排出的，有明确安装意愿的商户 ELEME-饿了么的商户 GD_EVALUATION-高德评价通的商户 GD_ONLINE-高德线上投放的商户 ELEME_RETAIL-饿了么零售的商户 ELEME_BRAND-饿了么品牌的商户
        /// </summary>
        [XmlArray("task_tags")]
        [XmlArrayItem("string")]
        public List<string> TaskTags { get; set; }

        /// <summary>
        /// 任务拉取时无该内容返回，确认领取时返回脱敏内容，如131****2222，确认商户有意图或呼叫商户N次未接通的情况会返回该字段未脱敏数据，N以实际业务沟通为准
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 在用经营工具，如：收银系统，点单产品
        /// </summary>
        [XmlArray("using_biz_tools")]
        [XmlArrayItem("string")]
        public List<string> UsingBizTools { get; set; }
    }
}
