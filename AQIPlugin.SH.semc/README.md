#˵��

��������ΪAMF��ʽ
���ݽӿڵ�ַΪhttp://www.semc.gov.cn/aqi/Gateway.aspx
���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ������ӿ�


����Ϊ�ӿ��б�
| ����                          | ����                  |��������   |����ʽ  |
| ----------------------------- |:--------------------- |:---------:|:--------:|
| GetMaxDayAQI					|����24Сʱ���AQI		|JSON(AMF)	|POST
| GetMaxDayAQI1					|����24Сʱ���AQI		|JSON(AMF)	|POST
| getSHSiteValueData			|����24Сʱƽ��Ũ��		|JSON(AMF)	|POST
| 
| GetAllCityList				|����24Сʱ��ʷAQI		|JSON(AMF)	|POST
| GetAllCityList1				|����24Сʱ��ʷAQI		|JSON(AMF)	|POST
| GetValueTrend					|����24Сʱ��ʷŨ��		|JSON(AMF)	|POST
| GetRecentlyDays				|����30����ʷAQI		|JSON(AMF)	|POST
|
| getTOP1siteid					|վ��1Сʱ���AQIվ��	|JSON(AMF)	|POST
| getSiteValueData				|վ��1СʱŨ��			|JSON(AMF)	|POST
| getSiteAQIData				|վ��1СʱAQI			|JSON(AMF)	|POST
| GetSiteValueTrend				|վ��24Сʱ��ʷŨ��		|JSON(AMF)	|POST
| GetSiteAqiTrend				|վ��24Сʱ��ʷAQI		|JSON(AMF)	|POST
|
| getUpdateTime					|���ݸ���ʱ��			|JSON(AMF)	|POST
|
| _5							|DSId����				|JSON(AMF)	|POST


##����
get5Info
�ӿ��Ǹ�����Ϣ��һ�ΰ�������5����Ϣ�Ľӿڣ���MessageBin�п����ҵ����ֽ�����Ϣ��



##����˵��
���ڷ�����������Cookie��DSId�ɶ�����֤�����Ա���ͨ�� _5 �����ȡDSId��Cookie��
�����нӿڶ��̳���semcSrcUrl��
��дICacheParam��ط���������LoadParamsʱ��ͨ�� _5 ��ȡDSId���������Cookie���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��
��дIParseSrcUrlParam��ط����������Զ���� _5 �Ľ������ȡDSId��Cookie��
��дIMakeParam��ط����������滻DSId���滻stationCode��cityCode��pollutantCode


###DSId�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
���ܲ���ʹ��ʲô��ʽ����Ҫ��AqiParam�����һ��replaceDSId��������ָ�������е�����ԭ�е�DSId


###stationCode��cityCode��pollutantCode�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
����ӿ���ҪcityCode��stationCode����������Ҫ�ڲ��������һ��replaceCityCode��replaceStationCode��������ָ�������е�����ԭ�е�����
����ӿ���ҪcityCode����������Ҫ�ڲ��������һ��replaceCityCode��������ָ�������е�����ԭ�е�����
����ӿ���ҪpollutantCode����������Ҫ�ڲ��������һ��pollutantCode��������ָ�������е�����ԭ�е�����


#������ȫ
getSiteValueData
getSiteAQIData
GetSiteValueTrend
GetSiteAqiTrend