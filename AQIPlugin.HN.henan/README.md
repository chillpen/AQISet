#˵��

��������ΪAMF��ʽ
���ݽӿڵ�ַΪhttp://222.143.24.250:100/airgis_dp/messagebroker/amf
���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ������ӿ�


����Ϊ�ӿ��б�
| ����                          | ����                  |��������   |����ʽ  |
| ----------------------------- |:--------------------- |:---------:|:--------:|
| findMainCityAqiInfo			|����1СʱAQI			|JSON(AMF)	|POST
| findCityInfoDAByCityCode		|����24СʱAQI			|JSON(AMF)	|POST
| find10DaysDayAqiInfoByCode	|����10����ʷAQI		|JSON(AMF)	|POST
| 
| findAqiInfoByCityCode			|����վ��1СʱAQI		|JSON(AMF)	|POST
| findNdInfoByCityCode			|����վ��1СʱŨ��		|JSON(AMF)	|POST
| 
| find12HourAqiInfoByCode		|����վ��12Сʱ��ʷAQI	|JSON(AMF)	|POST
| find12HourNdInfoByCode		|����վ��12Сʱ��ʷŨ��	|JSON(AMF)	|POST
| find24HourAqiInfoByCode		|����վ��24Сʱ��ʷAQI	|JSON(AMF)	|POST
| find24HourNdInfoByCode		|����վ��24Сʱ��ʷŨ��	|JSON(AMF)	|POST
| 
| getCityHourInfo				|����1СʱŨ��			|JSON(AMF)	|POST
| _5							|DSId����				|JSON(AMF)	|POST


##����
getCityHourInfo
�ӿ�Ŀǰ�������κ����ݣ��ʹر�

find8InfoByCityCode
�ӿ��Ǹ�����Ϣ��һ�ΰ�������8����Ϣ�Ľӿڣ���MessageBin�п����ҵ����ֽ�����Ϣ��



##����˵��
���ڷ�����������Cookie��DSId�ɶ�����֤�����Ա���ͨ�� _5 �����ȡDSId��Cookie��
�����нӿڶ��̳���henanSrcUrl��
��дICacheParam��ط���������LoadParamsʱ��ͨ�� _5 ��ȡDSId���������Cookie���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��
��дIParseSrcUrlParam��ط����������Զ���� _5 �Ľ������ȡDSId��Cookie��
��дIMakeParam��ط����������滻DSId���滻stationCode��cityCode


###DSId�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
���ܲ���ʹ��ʲô��ʽ����Ҫ��AqiParam�����һ��replaceDSId��������ָ�������е�����ԭ�е�DSId


###stationCode��cityCode�滻��ʽ
���ֽ���������ϵģ�����MakeRequestBody��Ϻ�����滻��
����ӿ���ҪcityCode��stationCode����������Ҫ�ڲ��������һ��replaceCityCode��replaceStationCode��������ָ�������е�����ԭ�е�����
����ӿ���ҪcityCode����������Ҫ�ڲ��������һ��replaceCityCode��������ָ�������е�����ԭ�е�����


