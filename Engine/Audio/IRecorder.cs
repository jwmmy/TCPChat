﻿using Engine.Model.Common.Entities;
using System;
using System.Collections.Generic;

namespace Engine.Audio
{
  public interface IRecorder : IDisposable
  {
    /// <summary>
    /// Происходит при заполнении буффера.
    /// </summary>
    event EventHandler<RecordedEventArgs> Recorded;

    /// <summary>
    /// Устанавливает настройки качества записи. И устройство записывающее звук.
    /// </summary>
    /// <param name="deviceName">Имя устройства.</param>
    /// <param name="quality">Количество записи.</param>
    void SetOptions(string deviceName, AudioQuality quality);

    /// <summary>
    /// Запускает запись с микрофона.
    /// </summary>
    void Start();

    /// <summary>
    /// Останавливает запись с микрофона.
    /// </summary>
    void Stop();

    /// <summary>
    /// Возвращает заначение говоряеще о том инциализирован ли класс.
    /// </summary>
    bool IsInited { get; }

    /// <summary>
    /// Возвращает список утросйств записывающих звук.
    /// </summary>
    IList<string> Devices { get; }
  }
}
