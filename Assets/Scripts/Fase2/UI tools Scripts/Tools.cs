using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class Tools : MonoBehaviour
{
	public Text HerramientaActual;
	public GameObject panelBotonesOperaciones;
	public GameObject panelEditar;
	public GameObject panelPadre;
	public botones opcionPanel;
	public GameObject panelCortar;
	public GameObject panelCrecer;
	public GameObject panelGirar;
	public Bandera opcionBandera;
	public Bandera OpcionCortar;
	public Bandera giro;
	public Image[] imagenAEditar;
	//public bool opcion4;
	public Canvas canvas;
	//public int bandera;
	public GameObject tmp;
	// Use this for initialization
	EventTrigger eventTrigger = null;
	
	//[SerializeField]
	//private Text textField = null;
	
	//[SerializeField]
	//private Toggle toggle = null;
	
	// Use this for initialization
	void Start()
	{
		//opcion4 = false;
		panelBotonesOperaciones = GameObject.Find("PanelBotones");
		//panelCrecer = GameObject.FindGameObjectWithTag("PanelCrecer");
		panelEditar = GameObject.Find("Area de Trabajo");
		panelPadre = GameObject.Find("Canvas");
		tmp = GameObject.Find("Grupo");
		//panelCortar = GameObject.FindGameObjectWithTag ("PanelCortar");

		//Debug.Log (panelCortar.tag);

		opcionPanel = panelBotonesOperaciones.GetComponent<botones>();
		opcionBandera = panelCrecer.GetComponent<Bandera>();
		OpcionCortar = panelCortar.GetComponent<Bandera> ();
		giro = panelGirar.GetComponent<Bandera> ();

		imagenAEditar = transform.GetComponentsInParent<Image>(); //El indice 1 es el que editara
		
		eventTrigger = gameObject.GetComponent<EventTrigger>();
		
		AddEventTrigger(OnPointerClick, EventTriggerType.PointerClick);
		//	AddEventTrigger(OnPointerEnter, EventTriggerType.PointerEnter, toggle);
		AddEventTrigger(OnPointerEnter, EventTriggerType.PointerEnter);
		AddEventTrigger(OnPointerExit, EventTriggerType.PointerExit);
		AddEventTrigger(OnPointerDown, EventTriggerType.PointerDown);
		AddEventTrigger(OnPointerUp, EventTriggerType.PointerUp);
		AddEventTrigger(OnDrag, EventTriggerType.Drag);
		AddEventTrigger(OnDrop, EventTriggerType.Drop);
		AddEventTrigger(OnScroll, EventTriggerType.Scroll);
		
	}


	void Update(){
		if ( canvas.GetComponent <CargarImgs> ().agrupados == 0) {
			canvas.GetComponent <CargarImgs> ().opcion4 = false;
		}
	}




	#region TriggerEventsSetup



	// Use listener with no parameters
	private void AddEventTrigger(UnityAction action, EventTriggerType triggerType)
	{
		// Create a nee TriggerEvent and add a listener
		EventTrigger.TriggerEvent trigger = new EventTrigger.TriggerEvent();
		trigger.AddListener((eventData) => action()); // ignore event data
		
		// Create and initialise EventTrigger.Entry using the created TriggerEvent
		EventTrigger.Entry entry = new EventTrigger.Entry() { callback = trigger, eventID = triggerType };
		
		// Add the EventTrigger.Entry to delegates list on the EventTrigger
		eventTrigger.triggers.Add(entry);
	}
	
	// Use listener that uses the BaseEventData passed to the Trigger
	private void AddEventTrigger(UnityAction<BaseEventData> action, EventTriggerType triggerType)
	{
		// Create a nee TriggerEvent and add a listener
		EventTrigger.TriggerEvent trigger = new EventTrigger.TriggerEvent();
		trigger.AddListener((eventData) => action(eventData)); // capture and pass the event data to the listener
		
		// Create and initialise EventTrigger.Entry using the created TriggerEvent
		EventTrigger.Entry entry = new EventTrigger.Entry() { callback = trigger, eventID = triggerType };
		
		// Add the EventTrigger.Entry to delegates list on the EventTrigger
		eventTrigger.triggers.Add(entry);
	}
	
	// Use listener that uses additional argument
	private void AddEventTrigger(UnityAction<Toggle> action, EventTriggerType triggerType, Toggle toggle)
	{
		// Create a nee TriggerEvent and add a listener
		EventTrigger.TriggerEvent trigger = new EventTrigger.TriggerEvent();
		trigger.AddListener((eventData) => action(toggle)); // pass additonal argument to the listener
		
		// Create and initialise EventTrigger.Entry using the created TriggerEvent
		EventTrigger.Entry entry = new EventTrigger.Entry() { callback = trigger, eventID = triggerType };
		
		// Add the EventTrigger.Entry to delegates list on the EventTrigger
		eventTrigger.triggers.Add(entry);
	}
	
	#endregion
	
	
	#region Callbacks
	/*public Image clon;

	public void  Prueba_corte(){
		
		if (Input.mousePresent) {
			clon = Instantiate (imagenAEditar [0]);
			Destroy (imagenAEditar [0]);


			clon.type = Image.Type.Filled;


		}
	}*/


	private void OnPointerClick(BaseEventData data)
	{
		//textField.text = "OnPointerClick " + data.selectedObject;
		
		// es frente
		if (opcionPanel.opcion == 1) {  
			imagenAEditar[0].gameObject.transform.SetParent(panelPadre.transform);
			imagenAEditar[0].gameObject.transform.SetParent(panelEditar.transform);
			HerramientaActual.text = "Traer al Frente";
		}
		//cortar
		if (opcionPanel.opcion == 8 || opcionPanel.opcion == 7 || opcionPanel.opcion == 6) {
			imagenAEditar[0].type = Image.Type.Filled;
			HerramientaActual.text = "Cortar";
			//imagenAEditar[0].fillAmount -=0.05f;

			//clon.fillAmount -=0.05f;



		}
		//rotar
		if (opcionPanel.opcion == 3) {
			HerramientaActual.text = "Girar";
			if(giro.bandera == 0)
				imagenAEditar[0].rectTransform.Rotate (Vector3.back*5);
			else
				imagenAEditar[0].rectTransform.Rotate (Vector3.back*-5);
		}
		if (opcionPanel.opcion == 4) {
			canvas.GetComponent <CargarImgs> ().agrupados ++;

			imagenAEditar[0].transform.SetParent(tmp.transform);
			canvas.GetComponent <CargarImgs> ().opcion4 = true;
		}
		if (opcionPanel.opcion == 5) {
			HerramientaActual.text = "Crecer";
			Vector3 theScale = imagenAEditar[0].transform.localScale;
			theScale.x *= -1;
			imagenAEditar[0].transform.localScale = theScale;
			/*
			if(imagenAEditar[0].transform.rotation.y == 180)
			{
				imagenAEditar[0].transform.eulerAngles = new Vector3(0f,0f,0f);
			}else
			{
				imagenAEditar[0].transform.eulerAngles = new Vector3(0f,180f,0f);
			}*/
		}
		if (opcionPanel.opcion == 6) {

			if(OpcionCortar.bandera == 0){
				imagenAEditar[0].fillMethod = Image.FillMethod.Horizontal;
				imagenAEditar[0].fillOrigin = (int)Image.OriginHorizontal.Right;
				imagenAEditar[0].fillAmount -=0.05f;
				HerramientaActual.text = "Cortar H.";

			}else {
				imagenAEditar[0].fillMethod = Image.FillMethod.Horizontal;
				imagenAEditar[0].fillOrigin = (int)Image.OriginHorizontal.Left;
				imagenAEditar[0].fillAmount -=0.05f;
				HerramientaActual.text = "Cortar H.";
			}

		}
		if (opcionPanel.opcion == 7) {

			if (OpcionCortar.bandera == 0){
				imagenAEditar[0].fillMethod = Image.FillMethod.Vertical;
				imagenAEditar[0].fillOrigin = (int)Image.OriginVertical.Bottom;
				HerramientaActual.text = "Cortar V.";
				imagenAEditar[0].fillAmount -=0.05f;
			} else {
				imagenAEditar[0].fillMethod = Image.FillMethod.Vertical;
				imagenAEditar[0].fillOrigin = (int)Image.OriginVertical.Top;
				imagenAEditar[0].fillAmount -=0.05f;
				HerramientaActual.text = "Cortar V.";

			}

		}
		if (opcionPanel.opcion == 8) {

			if(OpcionCortar.bandera == 0) {
				imagenAEditar[0].fillMethod = Image.FillMethod.Radial360;
				imagenAEditar[0].fillOrigin = (int)Image.Origin360.Right;
				imagenAEditar[0].fillAmount -=0.05f;
				HerramientaActual.text = "Cortar C.";

			}else {
				imagenAEditar[0].fillMethod = Image.FillMethod.Radial360;
				imagenAEditar[0].fillOrigin = (int)Image.Origin360.Left;
				imagenAEditar[0].fillAmount -=0.05f;
				HerramientaActual.text = "Cortar C.";

			}
		}

		if (opcionPanel.opcion == 9) {
			agrupadosGP(0.2f,0.2f);
			HerramientaActual.text = "Crecer";

			if(opcionBandera.bandera == 1)
			{
				imagenAEditar[0].preserveAspect= false;
				imagenAEditar[0].rectTransform.sizeDelta = new Vector2(imagenAEditar[0].rectTransform.sizeDelta.x+5,imagenAEditar[0].rectTransform.sizeDelta.y+5);

			}else
			{
				imagenAEditar[0].preserveAspect= false;
				imagenAEditar[0].rectTransform.sizeDelta = new Vector2(imagenAEditar[0].rectTransform.sizeDelta.x-5,imagenAEditar[0].rectTransform.sizeDelta.y-5);
			}
			
		}
		if (opcionPanel.opcion == 10) {
			HerramientaActual.text = "Crecer";
			agrupadosGP(0.2f, 0);
			if(opcionBandera.bandera == 1)
			{

				imagenAEditar[0].preserveAspect= false;
				imagenAEditar [0].rectTransform.sizeDelta = new Vector2 (imagenAEditar [0].rectTransform.sizeDelta.x + 5, imagenAEditar [0].rectTransform.sizeDelta.y);
				//imagenAEditar [0].sprite.texture.
			}else 
			{
				imagenAEditar[0].preserveAspect= false;
				imagenAEditar[0].rectTransform.sizeDelta = new Vector2(imagenAEditar[0].rectTransform.sizeDelta.x-5,imagenAEditar[0].rectTransform.sizeDelta.y);
					
			}
		} 
		if (opcionPanel.opcion == 11) {
			HerramientaActual.text = "Crecer";
			agrupadosGP(0, 0.2f);

			if(opcionBandera.bandera == 1)
			{
				imagenAEditar[0].preserveAspect= false;
				imagenAEditar [0].rectTransform.sizeDelta = new Vector2 (imagenAEditar [0].rectTransform.sizeDelta.x, imagenAEditar [0].rectTransform.sizeDelta.y + 5);
			}else {
				imagenAEditar[0].preserveAspect= false;
				imagenAEditar[0].rectTransform.sizeDelta = new Vector2(imagenAEditar[0].rectTransform.sizeDelta.x,imagenAEditar[0].rectTransform.sizeDelta.y-5);
					
			}
		}

		if (opcionPanel.opcion == 12) {
			HerramientaActual.text = "Borrar";

			Destroy(imagenAEditar[0].gameObject);
		}
		//Debug.Log("OnPointerClick ");
	}

	private void OnPointerEnter()
	{
		//Debug.Log( "OnPointerEnter");
	}
	private void OnPointerExit()
	{
		//Debug.Log("OnPointerExit");
	}
	
	private void OnPointerDown()
	{
		//Debug.Log("Entra down");
		
	}
	
	private void OnPointerUp()
	{
		
		//Debug.Log( "OnPointerUp");
	} 
	
	private void OnDrag()
	{
		//Debug.Log("OnDrag");
	}
	
	private void OnDrop()
	{
		//Debug.Log("OnDrop");
	}
	
	private void OnScroll()
	{
		//Debug.Log("OnScroll");
	} 
	#endregion

	void agrupadosGP(float x, float y){
		if (canvas.GetComponent <CargarImgs> ().opcion4 == true) {
			if (opcionBandera.bandera == 1) {
				tmp.transform.localScale += new Vector3 (x, y);
			} else {
				tmp.transform.localScale -= new Vector3 (x, y);
			}
		}
	}
}