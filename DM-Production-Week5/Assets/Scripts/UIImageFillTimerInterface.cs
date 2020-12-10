using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageFillTimerInterface : MonoBehaviour
{
    private MathsHelpers m_mathsHelper;
    [SerializeField]
    private Timer m_timer;

    private Image m_fillImage;

    private void Start()
    {
        m_mathsHelper = new MathsHelpers();
        m_fillImage = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        float normalisedCurrentFill = m_mathsHelper.NormaliseValue(0, m_timer.m_eventTime, m_timer.m_currentTime);
        m_fillImage.fillAmount = normalisedCurrentFill;
    }

}