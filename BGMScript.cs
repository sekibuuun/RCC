using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMScript : MonoBehaviour
{
    //�V���O���g���ݒ肱������
    static public BGMScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    //�V���O���g���ݒ肱���܂�




    public AudioSource A_BGM;//AudioSource�^�̕ϐ�A_BGM��錾�@�Ή�����AudioSource�R���|�[�l���g���A�^�b�`
    public AudioSource B_BGM;//AudioSource�^�̕ϐ�B_BGM��錾�@�Ή�����AudioSource�R���|�[�l���g���A�^�b�`

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 

    void Start()
    {
        beforeScene = "StartScene";//�N�����̃V�[���� �������Ă���
        A_BGM.Play();//A_BGM��AudioSource�R���|�[�l���g�Ɋ��蓖�Ă�AudioClip���Đ�

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }




    //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h�@
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        //�Q�[���V�[����
        if (beforeScene == "HowToPlayScene2" && nextScene.name == "GameScene")
        {
            A_BGM.Stop();
            B_BGM.Play();
        }

        //�Q�[���I�[�o�[
        if (beforeScene == "GameScene" && nextScene.name == "EndScene")
        {
            B_BGM.Stop();
        }

        //���g���C
        if (beforeScene == "EndScene" && nextScene.name == "GameScene")
        {
            B_BGM.Play();
        }

        //�^�C�g��
        if (beforeScene == "EndScene" && nextScene.name == "StartScene")
        {
            A_BGM.Play();
        }


        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }
}
