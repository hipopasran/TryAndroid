using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roadControll : MonoBehaviour {

    public Transform[] points;
    public float speed = 5;

    private string startSectionName, sectionPath;
    private GameObject[] sectionLink;
    private Transform[] section;
    private GameObject sectionStart;
    private List<Transform> sectionDisabled;
    private float minPosX, addPosX;
    private int index;


    void Awake()
    {
        switch (SceneManager.GetActiveScene().name) // фильтр по имени сцен, чтобы в каждой из них, использовать свой набор шаблонов
        {
            
            case "play":
                startSectionName = "Default/road/road1"; // стартовый префаб платформы
                sectionPath = "Default/road"; // папка, где лежат шаблоны для данной сцены
                break;
        }
    }

    void Start()
    {
        minPosX = points[0].position.x;
        addPosX = Mathf.Abs(minPosX) * 3;

        StartGame();
    }

    Transform RandomSection()
    {
        sectionDisabled = new List<Transform>();
        foreach (Transform tr in section)
        {
            if (!tr.gameObject.activeSelf)
            {
                sectionDisabled.Add(tr);
            }
        }
        int rnd = Random.Range(0, sectionDisabled.Count);
        return sectionDisabled[rnd];
    }

    void AddSection()
    {
        Transform bock = RandomSection();
        if (index == points.Length) index = 0;
        bock.parent = points[index];
        bock.localPosition = Vector3.zero;
        bock.gameObject.SetActive(true);
        index++;
    }

    void StartGame()
    {
        sectionLink = Resources.LoadAll<GameObject>(sectionPath); // все префабы должны находится в папке Resources
        if (sectionLink.Length < 4)
        {
            Debug.Log(this + " Недостаточно объектов для построения уровня. Ошибка запуска игры.");
            return;
        }

        section = new Transform[sectionLink.Length];

        for (int i = 0; i < sectionLink.Length; i++)
        {
            GameObject clone = Instantiate(sectionLink[i]) as GameObject;
            clone.SetActive(false);
            section[i] = clone.transform;
        }

        GameObject link = Resources.Load<GameObject>(startSectionName);
        if (link == null)
        {
            Debug.Log(this + " Файл не найден: " + startSectionName + " Ошибка запуска игры.");
            return;
        }

        sectionStart = Instantiate(link) as GameObject;
        sectionStart.SetActive(true);
        sectionStart.transform.parent = points[1];
        sectionStart.transform.localPosition = Vector3.zero;

        Transform bock = RandomSection();
        bock.parent = points[0];
        bock.localPosition = Vector3.zero;
        bock.gameObject.SetActive(true);

        bock = RandomSection();
        bock.parent = points[2];
        bock.localPosition = Vector3.zero;
        bock.gameObject.SetActive(true);
    }

    void Update()
    {
        foreach (Transform tr in points)
        {
            tr.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if (tr.position.x < minPosX)
            {
                tr.position += new Vector3(addPosX, 0, 0);
                tr.GetChild(0).gameObject.SetActive(false);
                tr.DetachChildren();
                AddSection();
            }
        }
    }
}
