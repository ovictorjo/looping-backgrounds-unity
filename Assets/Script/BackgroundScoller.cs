using UnityEngine;

namespace Assets.Script
{
    public class BackgroundScoller : MonoBehaviour
    {
        [Range(-1f, 1f)] 
        private float _offset;

        [SerializeField] private float _scrollSpeed = 0.5f;
        private Material _mat;

        void Start()
        {
            _mat = GetComponent<Renderer>().material;
        }

        void Update()
        {
            MoveHorizontal();
        }


        void MoveVertical()
        {
            _offset += (Time.deltaTime * _scrollSpeed) / 10f;
            _mat.SetTextureOffset("_MainTex", new Vector2(0,_offset));
        }

        void MoveHorizontal()
        {
            _offset += (Time.deltaTime * _scrollSpeed) / 10f;
            _mat.SetTextureOffset("_MainTex", new Vector2(_offset, 0));
        }


    }
}
