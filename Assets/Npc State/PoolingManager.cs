using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Npc_State {
    public class PoolingManager : MonoBehaviour

    {
        public static PoolingManager Instance;
        public List<PoolingManager> PoolingObjects;
        private Dictionary<string, List<GameObject>> _objectPool;

        private void Awake()
        {
            Instance = this;
            _objectPool = new Dictionary<string,List<GameObject>>();
        }

        public GameObject Get(string objectName)
        {
            //1. �̹� ��������ִ� ������Ʈ�� �ִ��� Ȯ��

            if (!_objectPool.ContainsKey(objectName))
            {
                // �ѹ��� �� ������Ʈ�� �������������))
                var prefabToInstantiate = PoolingObjects.FirstOrDefault(obj => obj.name == objectName);
                _objectPool.Add(objectName, new List<GameObject>());

                var instance = Instantiate(prefabToInstantiate.prefab);
                _objectPool[objectName].Add(instance);

                return instance;
            }

            else // �̹� ������� ���� Ű ���� �ִٸ�
            {
                var possibleGameObject = _objectPool[objectName].FirstOrDefault(obj => obj.activeInHierarchy == false);
                if (possibleGameObject != null) return possibleGameObject;
                else
                {
                    var prefabToInstantiate = PoolingObjects.FirstOrDefault(obj => obj.name == objectName);
                    var newGameObject = Instantiate(prefabToInstantiate.prefab);
                    _objectPool[objectName].Add(newGameObject);
                    return newGameObject;
                }
            }
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


