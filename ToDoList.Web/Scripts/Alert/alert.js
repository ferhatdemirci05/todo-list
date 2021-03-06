!function (a) {
    a(["jquery"], function (a) {
        return function () {
            function b(a, b, c) {
                return o({
                    type: v.error,
                    iconClass: p().iconClasses.error,
                    message: a,
                    optionsOverride: c,
                    title: b
                });
            }
            function c(b, c) {
                return b || (b = p()), r = a("#" + b.containerId), r.length ? r : (c && (r = l(b)),
                    r);
            }
            function d(a, b, c) {
                return o({
                    type: v.info,
                    iconClass: p().iconClasses.info,
                    message: a,
                    optionsOverride: c,
                    title: b
                });
            }
            function e(a) {
                s = a;
            }
            function f(a, b, c) {
                return o({
                    type: v.success,
                    iconClass: p().iconClasses.success,
                    message: a,
                    optionsOverride: c,
                    title: b
                });
            }
            function g(a, b, c) {
                return o({
                    type: v.warning,
                    iconClass: p().iconClasses.warning,
                    message: a,
                    optionsOverride: c,
                    title: b
                });
            }
            function h(a, b) {
                var d = p();
                r || c(d), k(a, d, b) || j(d);
            }
            function i(b) {
                var d = p();
                return r || c(d), b && 0 === a(":focus", b).length ? void q(b) : void (r.children().length && r.remove());
            }
            function j(b) {
                for (var c = r.children(), d = c.length - 1; d >= 0; d--) k(a(c[d]), b);
            }
            function k(b, c, d) {
                var e = !(!d || !d.force) && d.force;
                return !(!b || !e && 0 !== a(":focus", b).length) && (b[c.hideMethod]({
                    duration: c.hideDuration,
                    easing: c.hideEasing,
                    complete: function () {
                        q(b);
                    }
                }), !0);
            }
            function l(b) {
                return r = a("<div/>").attr("id", b.containerId).addClass(b.positionClass), r.appendTo(a(b.target)),
                    r;
            }
            function m() {
                return {
                    tapToDismiss: !0,
                    toastClass: "toast",
                    containerId: "toast-container",
                    debug: !1,
                    showMethod: "fadeIn",
                    showDuration: 300,
                    showEasing: "swing",
                    onShown: void 0,
                    hideMethod: "fadeOut",
                    hideDuration: 1e3,
                    hideEasing: "swing",
                    onHidden: void 0,
                    closeMethod: !1,
                    closeDuration: !1,
                    closeEasing: !1,
                    closeOnHover: !0,
                    extendedTimeOut: 1e3,
                    iconClasses: {
                        error: "toast-error",
                        info: "toast-info",
                        success: "toast-success",
                        warning: "toast-warning"
                    },
                    iconClass: "toast-info",
                    positionClass: "toast-top-right",
                    timeOut: 5e3,
                    titleClass: "toast-title",
                    messageClass: "toast-message",
                    escapeHtml: !1,
                    target: "body",
                    closeHtml: '<button type="button">&times;</button>',
                    closeClass: "toast-close-button",
                    newestOnTop: !0,
                    preventDuplicates: !1,
                    progressBar: !1,
                    progressClass: "toast-progress",
                    rtl: !1
                };
            }
            function n(a) {
                s && s(a);
            }
            function o(b) {
                function d(a) {
                    return null == a && (a = ""), a.replace(/&/g, "&amp;").replace(/"/g, "&quot;").replace(/'/g, "&#39;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
                }
                function e() {
                    i(), k(), l(), m(), o(), s(), j(), f();
                }
                function f() {
                    var a = "";
                    switch (b.iconClass) {
                        case "toast-success":
                        case "toast-info":
                            a = "polite";
                            break;

                        default:
                            a = "assertive";
                    }
                    D.attr("aria-live", a);
                }
                function g() {
                    A.closeOnHover && D.hover(y, x), !A.onclick && A.tapToDismiss && D.click(w), A.closeButton && H && H.click(function (a) {
                        a.stopPropagation ? a.stopPropagation() : void 0 !== a.cancelBubble && a.cancelBubble !== !0 && (a.cancelBubble = !0),
                            A.onCloseClick && A.onCloseClick(a), w(!0);
                    }), A.onclick && D.click(function (a) {
                        A.onclick(a), w();
                    });
                }
                function h() {
                    D.hide(), D[A.showMethod]({
                        duration: A.showDuration,
                        easing: A.showEasing,
                        complete: A.onShown
                    }), A.timeOut > 0 && (C = setTimeout(w, A.timeOut), I.maxHideTime = parseFloat(A.timeOut),
                        I.hideEta = new Date().getTime() + I.maxHideTime, A.progressBar && (I.intervalId = setInterval(z, 10)));
                }
                function i() {
                    b.iconClass && D.addClass(A.toastClass).addClass(B);
                }
                function j() {
                    A.newestOnTop ? r.prepend(D) : r.append(D);
                }
                function k() {
                    if (b.title) {
                        var a = b.title;
                        A.escapeHtml && (a = d(b.title)), E.append(a).addClass(A.titleClass), D.append(E);
                    }
                }
                function l() {
                    if (b.message) {
                        var a = b.message;
                        A.escapeHtml && (a = d(b.message)), F.append(a).addClass(A.messageClass), D.append(F);
                    }
                }
                function m() {
                    A.closeButton && (H.addClass(A.closeClass).attr("role", "button"), D.prepend(H));
                }
                function o() {
                    A.progressBar && (G.addClass(A.progressClass), D.prepend(G));
                }
                function s() {
                    A.rtl && D.addClass("rtl");
                }
                function v(a, b) {
                    if (a.preventDuplicates) {
                        if (b.message === t) return !0;
                        t = b.message;
                    }
                    return !1;
                }
                function w(b) {
                    var c = b && A.closeMethod !== !1 ? A.closeMethod : A.hideMethod, d = b && A.closeDuration !== !1 ? A.closeDuration : A.hideDuration, e = b && A.closeEasing !== !1 ? A.closeEasing : A.hideEasing;
                    if (!a(":focus", D).length || b) return clearTimeout(I.intervalId), D[c]({
                        duration: d,
                        easing: e,
                        complete: function () {
                            q(D), clearTimeout(C), A.onHidden && "hidden" !== J.state && A.onHidden(), J.state = "hidden",
                                J.endTime = new Date(), n(J);
                        }
                    });
                }
                function x() {
                    (A.timeOut > 0 || A.extendedTimeOut > 0) && (C = setTimeout(w, A.extendedTimeOut),
                        I.maxHideTime = parseFloat(A.extendedTimeOut), I.hideEta = new Date().getTime() + I.maxHideTime);
                }
                function y() {
                    clearTimeout(C), I.hideEta = 0, D.stop(!0, !0)[A.showMethod]({
                        duration: A.showDuration,
                        easing: A.showEasing
                    });
                }
                function z() {
                    var a = (I.hideEta - new Date().getTime()) / I.maxHideTime * 100;
                    G.width(a + "%");
                }
                var A = p(), B = b.iconClass || A.iconClass;
                if ("undefined" != typeof b.optionsOverride && (A = a.extend(A, b.optionsOverride),
                    B = b.optionsOverride.iconClass || B), !v(A, b)) {
                    u++ , r = c(A, !0);
                    var C = null, D = a("<div/>"), E = a("<div/>"), F = a("<div/>"), G = a("<div/>"), H = a(A.closeHtml), I = {
                        intervalId: null,
                        hideEta: null,
                        maxHideTime: null
                    }, J = {
                        toastId: u,
                        state: "visible",
                        startTime: new Date(),
                        options: A,
                        map: b
                    };
                    return e(), h(), g(), n(J), A.debug && console && console.log(J), D;
                }
            }
            function p() {
                return a.extend({}, m(), w.options);
            }
            function q(a) {
                r || (r = c()), a.is(":visible") || (a.remove(), a = null, 0 === r.children().length && (r.remove(),
                    t = void 0));
            }
            var r, s, t, u = 0, v = {
                error: "error",
                info: "info",
                success: "success",
                warning: "warning"
            }, w = {
                clear: h,
                remove: i,
                error: b,
                getContainer: c,
                info: d,
                options: {},
                subscribe: e,
                success: f,
                version: "2.1.4",
                warning: g
            };
            return w;
        }();
    });
}("function" == typeof define && define.amd ? define : function (a, b) {
    "undefined" != typeof module && module.exports ? module.exports = b(require("jquery")) : window.toastr = b(window.jQuery);
});