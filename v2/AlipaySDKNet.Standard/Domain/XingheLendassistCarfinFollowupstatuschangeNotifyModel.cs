using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinFollowupstatuschangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinFollowupstatuschangeNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 用户当前阻塞状态
        /// </summary>
        [XmlElement("blocking_status")]
        public string BlockingStatus { get; set; }

        /// <summary>
        /// 客服（坐席）信息
        /// </summary>
        [XmlElement("customer_service_info")]
        public CustomerServiceInfo CustomerServiceInfo { get; set; }

        /// <summary>
        /// 跟进结论列表
        /// </summary>
        [XmlArray("followup_res_list")]
        [XmlArrayItem("string")]
        public List<string> FollowupResList { get; set; }

        /// <summary>
        /// 跟进状态
        /// </summary>
        [XmlElement("followup_status")]
        public string FollowupStatus { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 申请单当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 车辆抵押到期日期 （followup_res_list中包含V_MORTGAGED_VEHICLE时传输）
        /// </summary>
        [XmlElement("vehicle_mortgage_expiry_date")]
        public string VehicleMortgageExpiryDate { get; set; }
    }
}
