# ˵��

���ݷ�ʽ: AMF

���ݽӿ�: http://222.143.24.250:100/airgis_dp/messagebroker/amf

> ���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                        |  ����                  | �������� | ����ʽ
| ----------------------------|:-----------------------|:--------:|:--------:|
| findMainCityAqiInfo         | ����1СʱAQI           | JSON(AMF)| POST
| findCityInfoDAByCityCode    | ����24СʱAQI          | JSON(AMF)| POST
| find10DaysDayAqiInfoByCode  | ����10����ʷAQI        | JSON(AMF)| POST
| 
| findAqiInfoByCityCode       | ����վ��1СʱAQI       | JSON(AMF)| POST
| findNdInfoByCityCode        | ����վ��1СʱŨ��      | JSON(AMF)| POST
| 
| find12HourAqiInfoByCode     | ����վ��12Сʱ��ʷAQI  | JSON(AMF)| POST
| find12HourNdInfoByCode      | ����վ��12Сʱ��ʷŨ�� | JSON(AMF)| POST
| find24HourAqiInfoByCode     | ����վ��24Сʱ��ʷAQI  | JSON(AMF)| POST
| find24HourNdInfoByCode      | ����վ��24Сʱ��ʷŨ�� | JSON(AMF)| POST
| 
| getCityHourInfo             | ����1СʱŨ��          | JSON(AMF)| POST
| _5                          | DSId����               | JSON(AMF)| POST


# ���ýӿ�
  + getCityHourInfo �ӿ�Ŀǰ�������κ����ݣ��ʹر�


# ���Ͻӿڣ��߼���ӣ�
  + find8InfoByCityCode �ӿ��Ǹ�����Ϣ��һ�ΰ�������8����Ϣ�Ľӿڣ���MessageBin�п����ҵ����ֽ�����Ϣ��


# ��֤
���ڷ����������� _Cookie_ �� _DSId_ �ɶ�����֤��
���Ա���ͨ�� `_5` �ӿ������ȡ _DSId_ �� _Cookie_ ��

�нӿڶ��̳��� `henanSrcUrl`
 - ��д **ICacheParam** ��ط���

			 ���� LoadParams ʱ��ͨ�� `_5` ��ȡ _DSId_ �������
			 ��_Cookie_ ���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��

 - ��д **IParseSrcUrlParam** ��ط���

       �����Զ���� `_5` �Ľ������ȡ _DSId_ �� _Cookie_��

 - ��д **IMakeParam** ��ط���

       �����滻DSId���滻stationCode��cityCode


# �����滻
���� AMF �Ĳ����� HTTP Body ���棬�����Ƕ����Ƶģ���ʹ�ò����滻��
���� MakeRequestBody ��Ϻ�����滻��


> ���ܶ����Ʋ���ʹ�ñ��ָ�ʽ����Ҫ�� AqiParam �����һ�� _replaceDSId_ ��������ָ�������Ʋ����е�ԭʼ _DSId_ ��

> ����ӿ���Ҫ _cityCode_ �� _stationCode_ ����������Ҫ�ڲ��������һ�� _replaceCityCode_��_replaceStationCode_ ��������ָ�������Ʋ����е�ԭʼ _cityCode_ �� _stationCode_ �� _pollutantCode_��
