# ˵��

���ݷ�ʽ: WebApi

���ݽӿ�: http://61.166.240.109:6013/

> ���ڽӿڲ��� Action ��������ʽ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                    | ����                    | �������� | ����ʽ
| ----------------------- |:----------------------- |:--------:|:--------:|
| citylist                | �����б�                | JSON     | GET
| queryStationList        | վ���б�                | JSON     | GET
| queryCityNotice         | ����֪ͨ                | JSON     | GET
|
| queryLatestTime         | 24Сʱ����ʱ��          | JSON     | GET
| queryCityAQIInfo        | ��������24СʱAQI�ȼ�   | JSON     | POST
| queryDailyDataOfCitys   | ����24СʱAQI           | JSON     | GET
| queryAreaDailyData      | վ��24СʱAQI           | JSON     | GET
| queryAQIDetail          | ����վ��24СʱAQI�ȼ�   | JSON     | GET
| queryStationDataList    | վ��24СʱAQI           | JSON     | GET
|
| queryLatestTime_2       | 1Сʱ����ʱ��           | JSON     | GET
| queryCityAQIInfo_2      | ��������1СʱAQI�ȼ�    | JSON     | POST
| queryRealDataOfCitys    | ����1СʱAQI            | JSON     | GET
| queryRealData           | վ��1СʱAQI            | JSON     | GET
| queryCTDetail           | ����վ��1СʱAQI�ȼ�    | JSON     | GET
| queryCTDetail_HISTORY   | ����վ��1Сʱ��Ⱦ����ʷ | JSON     | GET


## 1Сʱ��24Сʱ�ӿں����ƣ��������

| 24Сʱ                  | 1Сʱ                  | �Ƚ�      |
| ----------------------- | ---------------------- |:---------:|
| queryLatestTime         | queryLatestTime_2      | ģ��һ��
| queryCityAQIInfo        | queryCityAQIInfo_2     | ģ��һ��
| queryDailyDataOfCitys   | queryRealDataOfCitys   | ģ��һ��
| queryAreaDailyData      | queryRealData          | ģ�ͻ���һ����ǰ��û����Ⱦ�����ֻ�ܻ�ȡAQI����������Ⱦ��������Ի�ȡAQI��������Ⱦ��
| queryAQIDetail          | queryCTDetail          | ģ�ͻ���һ����ǰ��û����Ⱦ�����ֻ�ܻ�ȡAQI�������Ƿ��ͽӿڣ�����������Ⱦ��ʱ������Ⱦ����ʷ����


# ���ͽӿڣ��߼����ӣ�
  + �ӿ���ͬ��������ͬģ�Ͳ�ͬ
    - queryCTDetail ʹ��AQI���������¼��1Сʱ
    - queryCTDetail_HISTORY ʹ����Ⱦ����������¼��24Сʱ


# ���ýӿڣ�Ĭ�Ϲرգ�
  + queryCityNotice ��û�з������ݷ���
  + queryLatestTime ֻ�ǻ�ȡ���ݵ�ʱ�䣬�������������Ѿ�������ʱ��
  + queryStationDataList ���� queryAreaDailyData ��������,�������ظ���


# �ظ��ӿڣ�Ĭ�Ϲرգ�

| ����                    | �ظ���                 | ����                              |
| ----------------------- |:---------------------- |:---------------------------------:|
| queryCityAQIInfo        | queryDailyDataOfCitys  | ǰ����Ϣ��ȫ�����߿���������ȡ
| queryAQIDetail          | queryAreaDailyData     | ǰ����Ϣ��ȫ�����߿���������ȡ
|                         |                        |
| queryCityAQIInfo_2      | queryRealDataOfCitys   | ǰ����Ϣ��ȫ�����߿���������ȡ
| queryCTDetail           | queryRealData          | ǰ�ߵ�AQI�ȼ���Ϣ�еȼ���Ϣ�����߿���������ȡ�����ǲ������ȼ���ʾ
