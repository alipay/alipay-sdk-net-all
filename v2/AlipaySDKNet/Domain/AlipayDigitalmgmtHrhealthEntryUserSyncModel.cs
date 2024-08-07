using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEntryUserSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrhealthEntryUserSyncModel : AopObject
    {
        /// <summary>
        /// 该参数为候选人在供应商系统预约时选择的机构名称，由候选人选择体检机构后确定传入，字符串，蚂蚁系统接收后存入数据库用于后续业务操作，候选人预约成功时传入
        /// </summary>
        [XmlElement("agency_name")]
        public string AgencyName { get; set; }

        /// <summary>
        /// 证件名字，该参数为候选人在供应商机构体检时出示的有效证件，由候选人去现场体检后传回，字符串，蚂蚁系统接收之后用于校验是否为本人参加体检，候选人到检后传入
        /// </summary>
        [XmlElement("cert_genre")]
        public string CertGenre { get; set; }

        /// <summary>
        /// 该参数为候选人在供应商机构体检时录入的证件号+MD5生成，由候选人体检时传入，字符串，蚂蚁系统接收之后用于比对系统当前的候选人证件号是否匹配，候选人已到检后传入
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 该参数代表候选人预约了哪个城市的体检，候选人在供应商系统操作时选择，字符串，蚂蚁系统接收之后存入数据库供后续业务流程操作，候选人预约成功时必传
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// data_key用于校验供应商的权限，每一个接入系统的供应商只有一个该参数，供应商来对接时蚂蚁生成唯一参数线下给到供应商侧
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// form_no，唯一，用于确定唯一的候选人，是通过蚂蚁入职体检系统的数据库id加盐生成，字符串类型，用来确定唯一的候选人使用，不会为空
        /// </summary>
        [XmlElement("form_no")]
        public string FormNo { get; set; }

        /// <summary>
        /// 该参数为候选人在供应商系统选择的体检套餐名，由候选人选择套餐后确定传入，字符串，蚂蚁系统获取后存入数据供后续业务操作，候选人预约成功时传入
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 该参数为候选人在供应商系统体检完成，生成的体检报告下载链接，供应商系统生成体检报告后传入，字符串，蚂蚁系统接收之后通过链接下载到本地数据库用于后续业务处理，供应商生成报告时必传
        /// </summary>
        [XmlElement("report_link")]
        public string ReportLink { get; set; }

        /// <summary>
        /// 该参数用于确认候选人的预约体检的状态，根据双方约定好的状态码传入，字符串，蚂蚁系统使用该参数确定候选人预约状态并作下一步动作，必传，无默认值
        /// </summary>
        [XmlElement("reservation_status")]
        public string ReservationStatus { get; set; }

        /// <summary>
        /// 该参数为候选人在供应商系统预约体检时选择的体检时间，由候选人选择体检时间后传入，字符串，蚂蚁系统接收之后存入数据库用于后续业务动作，候选人预约成功后传入
        /// </summary>
        [XmlElement("reservation_time")]
        public string ReservationTime { get; set; }
    }
}
