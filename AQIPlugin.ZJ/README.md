#˵��

��������ΪAMF��ʽ
���ݽӿڵ�ַΪhttp://218.108.43.220:8099/aqi/messagebroker/amf
���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ������ӿ�


����Ϊ�ӿ��б�
����							����				��������		����ʽ
============================================================
getOneAndTwoLevelDivision		�����б�			JSON(AMF)			POST
getAreaUsedToDayReport			����24Сʱ�б�		JSON(AMF)			POST
getAreaUsedToRealTime			����1Сʱ�б�		JSON(AMF)			POST

getAreaDayReprotData			����24СʱAQI&Ũ��	JSON(AMF)			POST
getAreaRealTimeReportData		����1СʱAQI&Ũ��	JSON(AMF)			POST
								����24Сʱ��ʷAQI

getHourlyDataForAllSites		վ��1СʱAQI&Ũ��	JSON(AMF)			POST
								վ��24Сʱ��ʷAQI

_5								DSId����			JSON(AMF)			POST




##����
getAreaRealTimeReportData��3�ظ��Ͻӿ�
getHourlyDataForAllSites��2�ظ��Ͻӿ�




##����˵��
���ڷ�����������Cookie��DSId�ɶ�����֤�����Ա���ͨ�� _5 �����ȡDSId��Cookie��
�����нӿڶ��̳���semcSrcUrl��
��дICacheParam��ط���������LoadParamsʱ��ͨ�� _5 ��ȡDSId���������Cookie���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��
��дIParseSrcUrlParam��ط����������Զ���� _5 �Ľ������ȡDSId��Cookie��
��дIMakeParam��ط����������滻DSId


###DSId�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
���ܲ���ʹ��ʲô��ʽ����Ҫ��AqiParam�����һ��replaceDSId��������ָ�������е�����ԭ�е�DSId


###stationCode��cityCode��pollutantCode�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
����ӿ���ҪcityCode��stationCode����������Ҫ�ڲ��������һ��replaceCityCode��replaceStationCode��������ָ�������е�����ԭ�е�����
����ӿ���ҪcityCode����������Ҫ�ڲ��������һ��replaceCityCode��������ָ�������е�����ԭ�е�����
����ӿ���ҪpollutantCode����������Ҫ�ڲ��������һ��pollutantCode��������ָ�������е�����ԭ�е�����

