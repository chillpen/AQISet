#˵��

�������ݴ󲿷�ΪGET��ʽ
���ݽӿڵ�ַΪhttp://61.166.240.109:6013/YNAS/index.jsp
���ڽӿڲ���Action��������ʽ���ʰ����󷽷���ͬ���ֲ�ͬ������ӿ�


����Ϊ�ӿ��б�
����							����					��������		����ʽ
============================================================
citylist						�����б�				JSON			GET
queryStationList				վ���б�				JSON			GET
queryCityNotice					����֪ͨ				JSON			GET

queryLatestTime					24Сʱ����ʱ��			JSON			GET
queryDailyDataOfCitys			����24СʱAQI			JSON			GET
queryCityAQIInfo				��������24СʱAQI�ȼ�	JSON			POST
queryAreaDailyData				վ��24СʱAQI			JSON			GET
queryAQIDetail					����վ��24СʱAQI�ȼ�	JSON			GET
queryStationDataList			վ��24СʱAQI			JSON			GET

queryLatestTime_2				1Сʱ����ʱ��			JSON			GET
queryRealDataOfCitys			����1СʱAQI			JSON			GET
queryCityAQIInfo_2				��������1СʱAQI�ȼ�	JSON			POST
queryRealData					վ��1СʱAQI			JSON			GET
queryCTDetail					����վ��1СʱAQI�ȼ�	JSON			GET
queryCTDetail_HISTORY			����վ��1Сʱ��Ⱦ����ʷ	JSON			GET



1Сʱ��24Сʱ������ȣ��Ƚ��б�����

1Сʱ							24Сʱ						�Ƚ�
============================================================
queryLatestTime					queryLatestTime_2			һ��
queryDailyDataOfCitys			queryRealDataOfCitys		����һ��
queryCityAQIInfo				queryCityAQIInfo_2			����һ��
queryAreaDailyData				queryRealData				������������Ⱦ�����ݲ�����ǰ�߲��ɻ�ȡ��Ⱦ��
queryAQIDetail					queryCTDetail				������������Ⱦ����ʷ���ݲ�����ǰ�߲��ɻ�ȡ��Ⱦ��




��Щ�ӿ����ظ���
queryCTDetail��queryCTDetail_HISTORY�ӿ���ͬ���������ڲ�ͬ��ÿСʱ��ÿ��




��Щ���������õ�
queryLatestTime��queryLatestTime_2���ֻ�ǻ�ȡ���ݵ�ʱ�䣬�������������Ѿ�������ʱ��
queryCityNotice��û�з������ݷ���
queryStationDataList����queryAreaDailyData��������,�������ظ���




����ĳЩ�������ظ��ģ����г�

����							�ظ���					����
============================================================
queryCityAQIInfo				queryDailyDataOfCitys	���߿���������ȡ��ǰ����Ϣ��ȫ
queryAQIDetail					queryAreaDailyData		���߿���������ȡ

queryCityAQIInfo_2				queryRealDataOfCitys	���߿���������ȡ
queryCTDetail					queryRealData			���߿���������ȡ�����ǲ������ȼ���ʾ