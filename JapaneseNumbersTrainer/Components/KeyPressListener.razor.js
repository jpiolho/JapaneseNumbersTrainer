let instance = null;

export function registerEvent(dotnetInstance) {
    instance = dotnetInstance;
    window.addEventListener('keydown',callback);
}

export function unregisterEvent() {
    window.removeEventListener('keydown', callback);
}


function callback(event) {
    instance.invokeMethodAsync('OnKeyPressed',event.key);
}
