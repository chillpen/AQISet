# ˵��

���ݷ�ʽ: WebApi

���ݽӿ�: http://typhoon.zjwater.gov.cn/Api/

> ������ʽ������ͬ���ֲ�ͬ������ӿ�


# �ӿ��б�

| ����                    | ����                   | �������� | ����ʽ
| ----------------------- |:---------------------- |:--------:|:--------:|
| LeastCloud              | ��ͼ                   | JSON     | GET
| LeastRain               | ��ͼ                   | JSON     | GET
| TyhoonActivity          | ��ǰ̨���б�           | JSON     | GET
| TyphoonInfo             | ̨������               | JSON     | GET
| TyphoonList             | ̨����ʷ�б�           | JSON     | GET



# �Զ����ӿ�
  + ����TyphoonList���Բ�ѯ��ʷ���ݣ�TyphoonList�ӿ�Ҳ�᲻������µ����ݣ�
    �������Զ����ӿ������ų����仯����ʷ�����¼����ΪÿСʱ����ʷ���ݽ����ȡһ�Σ���������ݻ᲻�ϻ�ȡ
    + TyphoonList_Auto ʹ��ParamFilterType.OnceAgain��ʽ���˲���

  + TyphoonInfo��ͨ��JSON�������ȡĳЩ�����ڵ����ݣ�̨��Ų����ڣ���
    TyphoonInfo�Ĳ���������TyphoonList��TyhoonActivity�д��ڵ�̨��ţ�
    ������2���Զ����ӿڣ���ȡ��ȷ��̨��Ų��������¼����ΪÿСʱ

    + TyphoonInfo_FormActivity ������TyhoonActivity�ӿڻ��
    + TyphoonInfo_FormList     ������TyphoonList_Auto�ӿڻ��